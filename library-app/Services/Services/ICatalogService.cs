﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public interface ICatalogService
    {
        public void ShowCatalog();

        public void FindBook(int id);
    }
}
