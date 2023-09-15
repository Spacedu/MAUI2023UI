﻿using Templates.Paginas;

namespace Templates
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("pagina1", typeof(Pagina1));
            Routing.RegisterRoute("pagina2", typeof(Pagina2));
        }
    }
}