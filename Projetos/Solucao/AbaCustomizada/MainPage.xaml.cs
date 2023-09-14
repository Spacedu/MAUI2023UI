﻿using AbaCustomizada.Abas;

namespace AbaCustomizada
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MostrarConteudoAba(string.Empty);
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            string aba = (string)e.Parameter;
            MostrarConteudoAba(aba);
        }

        private void MostrarConteudoAba(string aba)
        {
            ContentView content;
            switch (aba)
            {
                case "Início":
                    content = new Inicio();
                    break;
                case "Relatório":
                    content = new Relatorio();
                    break;
                case "Calendário":
                    content = new Calendario();
                    break;
                case "Perfil":
                    content = new Perfil();
                    break;
                default:
                    content = new Inicio();
                    break;
            }

            if (Container.Children.Count == 2)
            {
                Container.Children.Remove(Container.Children[0]);
            }
            Container.Children.Insert(0, content);
        }
    }
}