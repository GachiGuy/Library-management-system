bool isOpen = true;
string[,] books = {
    {"Пушкин","Лермонтов","Толстой" },
    {"Стивен Кинг","Говард Лавкрафт","Брэм Стокер" },
    {"Unity для начинающих","C++ для начинающих","Unreal Engine для начинающих" } 
};
while(isOpen)
{
    Console.WriteLine("Библиотека.");
    Console.WriteLine("\n 1 - узнать что за книга, зная её индекс.\n\n 2 - найти книгу по названию и автору.\n\n 3 - вывести все книги.\n\n 4 - выход.");
    Console.Write("Введите пункт меню: ");
    switch(Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            int rows;
            int cols;
            Console.Write("Введите номер полки: ");
            rows = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Введите номер: ");
            cols = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("\n Это книга - " + books[rows, cols]);
            break;
        case 2:
            string author;
            bool authorIsFind = false;
            Console.Write("Введите нужного автора: ");
            author = Console.ReadLine();
            for(int i = 0; i < books.GetLength(0); i++)
            {
                for(int j = 0; j < books.GetLength(1); j++)
                {
                    if(author.ToLower() == books[i,j ].ToLower())
                    {
                        Console.Write("Автор - " + books[i,j ] + "находится по адресу - " + (i + 1) + " " + (j + 1));
                        authorIsFind = true;
                    }
                }
            }
            if(authorIsFind == false)
            {
                Console.WriteLine("Такого автора нет.");
            }
            break;
        case 3:
            Console.WriteLine("\n Весь список авторов:\n ");
            for(int i = 0; i < books.GetLength(0); i++)
            {
                for (int j = 0; j < books.GetLength(1); j++)
                {
                    Console.WriteLine(books[i,j ]);
                }    
            }
            break;
        case 4:
            isOpen = false;
            break;
    }
    Console.Write("\n Нажмите любую клавишу для продолжения...");
    Console.ReadKey();
}
