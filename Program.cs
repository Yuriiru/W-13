
    internal class Program
    {
        class Book<T> : IBook
        {
            string book_name;
            string autor;
            T publish_date;
            int numbers_of_page;

            public Book(string book_name, string autor, T publish_date, int numbers_of_page)
            {
                this.book_name = book_name;
                this.autor = autor;
                this.publish_date = publish_date;
                this.numbers_of_page = numbers_of_page;

            }

            public void book_name_info()
            {
                Console.WriteLine($"Книга: {book_name}");
            }
            public void autor_info()
            {
                Console.WriteLine($"Автор: {autor}");
            }
            public void publish_date_info()
            {
                Console.WriteLine($"Дата публикации: {publish_date}");
            }
            public void number_page_info()
            {
                Console.WriteLine($"Количество страниц: {numbers_of_page}");
            }

        }

        class User<T> : IUser
        {
            T login;
            string password;

            public User(T login, string password)
            {
                this.login = login;
                this.password = password;
            }

            public void login_info()
            {
                Console.WriteLine($"Логин: {login}");
            }
            public void password_info()
            {
                Console.WriteLine($"Пароль: {password}");
            }
        }

        class Shop : IUser, IBook
        {
            string user_name;
            string book_name;

            public Shop(string user_name, string book_name)
            {
                this.user_name = user_name;
                this.book_name = book_name;
            }

            public void buy()
            {
                Console.WriteLine($"Пользователь: {user_name}, Купил книгу: {book_name}");
            }
            public void login_info()
            {
            }
            public void password_info()
            {
            }
            public void book_name_info()
            {
            }
            public void autor_info()
            {
            }
            public void publish_date_info()
            {
            }
            public void number_page_info()
            {
            }
        }


        interface Ipublish_house
        {
            void book_name_info();
            void autor_info();

        }


        interface IBook : Ipublish_house
        {
            void publish_date_info();
            void number_page_info();

        }


        interface IUser
        {
            void login_info();
            void password_info();
        }


        static void Main(string[] args)
        {

            Book<int> book1 = new Book<int>("Люди удачи", "Надифа Мохамед", 18052007, 450);
            Book<string> book2 = new Book<string>("Люди удачи", "Надифа Мохамед", "18 мая 2007 года", 450);

            User<string> user1 = new User<string>("Gbw73@", "ne94brE");
            User<int> user2 = new User<int>(926, "Hr82Xot");

            Shop shop = new Shop("Yurii", "V omyt s golovoi");
            shop.buy();

        }
    }

