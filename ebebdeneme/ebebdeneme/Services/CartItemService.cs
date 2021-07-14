﻿using ebebdeneme.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xamarin.Forms;

namespace ebebdeneme.Services
{

    public class CartItemService    
    {
        
        public int GetUserCartCount()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            var count = cn.Table<CartItem>().Count();
            cn.Close();
            return count;
            
        }
       
        public void RemoveItemsFromCart()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            cn.DeleteAll<CartItem>();
            cn.Commit();
            cn.Close();

        }

        
    }
}
