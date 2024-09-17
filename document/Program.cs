using System;

namespace DocumentApp
{
    class Document
    {
        private string type;
        private string title;
        private int numberOfPages;

        public Document()
        {
            type = "Невiдомий";
            title = "Без назви";
            numberOfPages = 0;
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int NumberOfPages
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }

        public void UpdateDocument(string type, string title, int numberOfPages)
        {
            this.type = type;
            this.title = title;
            this.numberOfPages = numberOfPages;

            Console.WriteLine("Оновленi данi документа:");
            Console.WriteLine($"Тип: {this.type}");
            Console.WriteLine($"Назва: {this.title}");
            Console.WriteLine($"Кількiсть сторiнок: {this.numberOfPages}");
        }
    }