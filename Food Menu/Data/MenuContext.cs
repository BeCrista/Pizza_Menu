using Microsoft.EntityFrameworkCore;
using Food_Menu.Models;

namespace Food_Menu.Data
{
    public class MenuContext : DbContext
    {
        public MenuContext(DbContextOptions<MenuContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DishIngredient>().HasKey(key => new
            {
                key.DishId,
                key.IngredientId
            });

            modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(d => d.DishId);
            modelBuilder.Entity<DishIngredient>().HasOne(i => i.Ingredient).WithMany(di => di.DishIngredients).HasForeignKey(i => i.IngredientId);


            modelBuilder.Entity<Dish>().HasData(
                new Dish
                {
                    Id = 1,
                    Name = "Pizza Margherita",
                    Price = 7.50,
                    ImageUrl = "https://br.giallozafferano.com/images/5-591/Pizza-Margherita_1200x800.jpg"
                }
                );
            modelBuilder.Entity<Ingredient>().HasData(
                new Ingredient
                {
                    Id= 1,
                    Name = "Tomato Sauce"
                },
                new Ingredient
                {
                    Id = 2,
                    Name = "Mozzarela"
                });

            modelBuilder.Entity<DishIngredient>().HasData(
                new DishIngredient
                {
                    DishId = 1,
                    IngredientId = 1
                },
                new DishIngredient{
                    DishId = 1,
                    IngredientId = 2
                });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set;}
        public DbSet<DishIngredient> DishIngredients { get; set; }
    }
}
