using BuilderBurger;

BurgerBuilder burgerBuilder = new BurgerBuilder();
BurgerDirector burgerDirector = new BurgerDirector(burgerBuilder);

burgerDirector.BuildWoper();

burgerDirector.BuildCheese();

burgerBuilder.GetBurger();



             
                             