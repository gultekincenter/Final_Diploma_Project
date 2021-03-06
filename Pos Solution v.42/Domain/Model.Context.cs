﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class POSEntities : DbContext
    {
        public POSEntities()
            : base("name=POSEntities")
        {
    		Areas = Set<Area>();	
    		Categories = Set<Category>();	
    		MenuProducts = Set<MenuProduct>();	
    		Payments = Set<Payment>();	
    		People = Set<Person>();	
    		Products = Set<Product>();	
    		Restaurants = Set<Restaurant>();	
    		Sales = Set<Sale>();	
    		SaleLineItems = Set<SaleLineItem>();	
    		UserAccounts = Set<UserAccount>();	
    		Tables = Set<Table>();	
    		Menus = Set<Menu>();	
    		Registers = Set<Register>();	
    
    
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        internal DbSet<Area> Areas { get; set; }
        internal DbSet<Category> Categories { get; set; }
        internal DbSet<MenuProduct> MenuProducts { get; set; }
        internal DbSet<Payment> Payments { get; set; }
        internal DbSet<Person> People { get; set; }
        internal DbSet<Product> Products { get; set; }
        internal DbSet<Restaurant> Restaurants { get; set; }
        internal DbSet<Sale> Sales { get; set; }
        internal DbSet<SaleLineItem> SaleLineItems { get; set; }
        internal DbSet<UserAccount> UserAccounts { get; set; }
        internal DbSet<Table> Tables { get; set; }
        internal DbSet<Menu> Menus { get; set; }
        internal DbSet<Register> Registers { get; set; }
    }
}
