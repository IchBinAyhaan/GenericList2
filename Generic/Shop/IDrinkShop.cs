
namespace Shop
{
    internal interface IDrinkShop<T> where T : Product
    {
        void AddProduct(T product);
        void SellProduct(string name, int quantity);
        void DisplayProducts();
        void ShowIncome();
    }
}
