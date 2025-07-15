  

namespace CleanArch.Domain.Product
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public int Price { get; private set; }

        public bool IsFinally { get; private set; }

        public DateTime FinallyDate { get; private set; }

        public Product(Guid id,string title , int price)
        {
            Guard(title, price);
            Id = Guid.NewGuid();
            Title = title;
            Price = price;
        }

        public void Finally()
        {
            IsFinally = true;
            FinallyDate = DateTime.Now;
        }

        public void Edit(string title, int price)
        {
            Guard(title,price);
            this.Title = title;
            this.Price = price;
        }

        public void Guard(string title, int price)
        {
            if(string.IsNullOrEmpty(title)) throw new ArgumentNullException("title");

            if (price < 0) throw new ArgumentOutOfRangeException("price");
        }
    }

    
}
