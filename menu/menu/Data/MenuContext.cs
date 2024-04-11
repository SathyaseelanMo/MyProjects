using menu.Models;
using Microsoft.EntityFrameworkCore;
namespace menu.Data
{
    public class MenuContext : DbContext
    { 
      public MenuContext(DbContextOptions<MenuContext> options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DishIngredient>().HasKey(di => new { di.DishId, di.IngredientId });
        modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(d => d.DishId);
        modelBuilder.Entity<DishIngredient>().HasOne(i => i.Ingredient).WithMany(di => di.DishIngredients).HasForeignKey(i => i.IngredientId);


        modelBuilder.Entity<Dish>().HasData(new Dish { Id = 1, Name = "Margheritta", ImageUrl = "https://www.tasteandtellblog.com/wp-content/uploads/2023/07/Margherita-Pizza-4.jpg", Price = 245 });

        modelBuilder.Entity<Ingredient>().HasData(new Ingredient { Id = 1, Name = "Tomato" }, new Ingredient { Id = 2, Name = "Mozarella" }, new Ingredient { Id = 3, Name = "Veggies" });


        modelBuilder.Entity<DishIngredient>().HasData(new DishIngredient { DishId = 1, IngredientId = 1 }, new DishIngredient { DishId = 1, IngredientId = 2 }, new DishIngredient { DishId = 1, IngredientId = 3 });



        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Dish> Dishes { get; set; }
    public DbSet<Ingredient> Ingredients { get; set; }

    public DbSet<DishIngredient> DishIngredients { get; set; }
}
}
