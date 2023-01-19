namespace BuilderBurger
{
    public interface IBurgerBuilder
    {
        void BuildGreens();

        void BuildTomatoes();

        void BuildCucumbers();

        void BuildOnion();

        void BuildCheese();

        void BuildCutlet();


        Burger GetBurger();
    }
}
