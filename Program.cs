using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Practice.DataContext;

// Console.Read();

DataContext context = new DataContext();

// -------------------------- 1 ------------------------------- // 
// Выбрать все продукты и соответствующие категории, чтобы получить полное представление о товарном ассортименте.
// var res = from cat in context.Categories
//           join prod in context.Products on cat.Id equals prod.CategoryId
//           where cat.Name == "Electronics"
//           select new
//           {
//               Name = prod.Name
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name);
// }


// ------------------------- 2 ----------------------- //
// Получить все заказы конкретного пользователя по его идентификатору, чтобы оценить его покупательскую активность.
// var res = from u in context.Users
//           join o in context.Orders on u.Id equals o.UserId
//           where u.Id == 1
//           select new
//           {
//               User = u.Username,
//               Order = o.TotalAmount
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.User + " " + r.Order);
// }



// ---------------------------- 3 ------------------------------ //
// Подсчитать общее количество продуктов в каждой категории, чтобы проанализировать распределение товаров по категориям.
// var res = from c in context.Categories
//           join p in context.Products on c.Id equals p.CategoryId
//           group c by p.Category into g
//           select new
//           {
//               Category = g.Key.Name,
//               Count = g.Count()
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Category + " " + r.Count);
// }


// -------------------------------- 4 ---------------------------------- //
// Составить список всех пользователей и их заказов, чтобы оценить активность каждого клиента в системе.
// var res = from u in context.Users
//           join o in context.Orders on u.Id equals o.UserId
//           select new
//           {
//               Name = u.Username,
//               Order = o.TotalAmount
//           };

// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name + " " + r.Order);
// }


// ----------------------------- 5 ------------------------------------ //
// Вывести все заказы, у которых суммарная стоимость превышает определенную сумму, для выявления крупных заказов.
// var res = from o in context.Orders
//           where o.TotalAmount > 500
//           select o;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.TotalAmount);
// }



// ------------------------ 6 ----------------------------- //
// Найти все продукты, которые есть в наличии (Stock > 0), чтобы составить актуальный список доступных товаров.
// var res = from p in context.Products
//           where p.Stock > 0
//           select p;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.Stock);
// }


// ------------------------------ 7 ------------------------------ //
// Получить информацию о заказах, сделанных после заданной даты, для анализа новых покупок.
// var res = from o in context.Orders
//           where o.OrderDate > DateTime.UtcNow.AddDays(-6)
//           select o;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.OrderDate);
// }


// ---------------------------------- 8 ------------------------------- //
// Подсчитать общее количество заказов для каждого пользователя, чтобы определить наиболее активных клиентов.
// var res = from u in context.Users
//           join o in context.Orders on u.Id equals o.UserId
//           group u by o.User into g
//           select new
//           {
//               Name = g.Key.Username,
//               Count = g.Count()
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name + " " + r.Count);
// }


// ----------------------------- 9 ---------------------------- //
// Найти всех пользователей, которые сделали заказы на определенную сумму, для оценки спроса на определенные товары.
// var res = from u in context.Users
//           join o in context.Orders on u.Id equals o.UserId
//           where o.TotalAmount == 150
//           select new
//           {
//               Name = u.Username,
//               Total = o.TotalAmount
//           };

// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name + " " + r.Total);
// }


// ------------------------- 10 ----------------------------- //
// Получить список продуктов и их цен, отсортированных по цене, чтобы легко сравнить стоимость товаров.
// var res = from p in context.Products
//           orderby p.Price descending
//           select p;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.Price);
// }


// ------------------------------- 11 ------------------------------- //
// Выбрать все заказы и соответствующие товары, чтобы проанализировать состав каждого заказа.
// var res = from o in context.Orders
//           join oi in context.OrderItems on o.Id equals oi.OrderId
//           join p in context.Products on oi.ProductId equals p.Id
//           select new
//           {
//               Order = o.Id,
//               OrderAmount = o.TotalAmount,
//               Product = p.Name
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Order + " " + r.OrderAmount + " " + r.Product);
// }


// -------------------------------------- 12 ------------------------------------ //
// Получить список категорий и их описаний, чтобы ознакомиться с ассортиментом и предложениями.
// var res = from c in context.Categories
//           select c;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name + " " + r.Description);
// }


// ------------------------------------ 13 ----------------------------- //
// Найти всех пользователей, у которых есть заказы, чтобы выделить активных клиентов.
// var res = from u in context.Users
//           join o in context.Orders on u.Id equals o.UserId
//           select new
//           {
//               UserName = u.Username,
//               OO = o.Id
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.UserName + " " + r.OO);
// }



// ---------------------------------- 14 ------------------------------------ //
// Получить все товары в конкретной категории, чтобы сосредоточиться на определенном сегменте товаров.
// var res = from c in context.Categories
//           join p in context.Products on c.Id equals p.CategoryId
//           where c.Name == "Electronics"
//           select p;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name);
// }


// ------------------------------------ 15 ------------------------------ //
// Найти все заказы, в которых присутствует определенный продукт, для оценки его популярности.
// var res = from o in context.Orders
//           join oi in context.OrderItems on o.Id equals oi.OrderId
//           join p in context.Products on oi.ProductId equals p.Id
//           where p.Name != "Smartphone"
//           select o;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.TotalAmount);
// }


// ------------------------------ 16 ----------------------------- //
// Получить информацию о последнем заказе каждого пользователя, чтобы отслеживать активность клиентов.
// var res = from u in context.Users
//           join o in context.Orders on u.Id equals o.UserId
//           group o by u.Id into g
//           select new
//           {
//               Name = g.Key,
//               LastOrder = g.Max(x => x.CreatedAt)
//           };

// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name + " " + r.LastOrder);
// }


// --------------------------------- 17 ------------------------------------ //
// Подсчитать общее количество товаров на складе, чтобы иметь представление о запасах.
// var res = context.Products.Sum(x => x.Stock);

// System.Console.WriteLine(res);


// -------------------------------- 18 --------------------------------- //
// Получить информацию о всех заказах и их суммах по каждому заказу для анализа финансовых показателей.
// var res = from o in context.Orders
//           where o.Id == 1
//           select o;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.TotalAmount);
// }



// ---------------------------------- 19 ------------------------------------ //
// Выбрать все удаленные продукты, чтобы выяснить, какие товары были исключены из ассортимента.
// var res = from p in context.Products
//           where p.IsDeleted == true
//           select p;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.Name);
// }



// ------------------------------------ 20 ------------------------------------ //
// Составить список пользователей, у которых не было заказов, для выявления потенциальных клиентов, нуждающихся в привлечении.
// var res = from u in context.Users
//           where !context.Orders.Any(x => x.UserId == u.Id)
//           select u;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.Username);
// }


// -------------------------------------- 21 ------------------------------------------ //
// Найти продукты, которые были добавлены в базу данных более трех месяцев назад и все еще доступны для продажи (Stock > 0).
// var res = from p in context.Products
//           where p.CreatedAt.Month < DateTime.UtcNow.Month - 3 && p.Stock > 0
//           select p;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.Name);
// }


// ------------------------------------------- 22 --------------------------------------- // 
// Получить список пользователей и общее количество уникальных продуктов, которые они заказали, чтобы определить разнообразие покупок.
// var res = from u in context.Users
//           join o in context.Orders on u.Id equals o.UserId
//           join oi in context.OrderItems on o.Id equals oi.OrderId
//           join p in context.Products on oi.ProductId equals p.Id
//           group p by u.Id into g
//           select new
//           {
//               Name = g.Key,
//               Count = g.Count()
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name + " " + r.Count);
// }



// ---------------------------------- 23 -------------------------------- //
// Составить отчет о том, сколько заказов было выполнено в каждый месяц за последний год.
// var res = from o in context.Orders
//           where o.CreatedAt.Year > DateTime.UtcNow.Year - 1
//           group o by o.OrderDate into g
//           select new
//           {
//               Year = g.Key.Year,
//               Month = g.Key.Month,
//               Count = g.Count()
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Year + " " + r.Month + " " + r.Count);
// }


// ------------------------------------ 24 ---------------------------------------- //
// Вывести все заказы и количество товаров в каждом заказе, чтобы проанализировать среднее количество продуктов в заказе.
// var res = from o in context.Orders
//           join oi in context.OrderItems on o.Id equals oi.OrderId
//           join p in context.Products on oi.ProductId equals p.Id
//           group p by o.Id into g
//           select new
//           {
//               Id = g.Key,
//               Count = g.Count()
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.Count);
// }


// ------------------------------------------ 25 -------------------------------------- //
// Определить, какая категория имеет наибольшую общую стоимость продаж (цена * количество) и вывести ее имя.
// var res = from c in context.Categories
//           join p in context.Products on c.Id equals p.CategoryId
//           group p by c.Name into g
//           select new
//           {
//               Name = g.Key,
//               Sum = g.Sum(x => x.Price * x.Stock)
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name + " " + r.Sum);
// }


// ------------------------------------------ 26 ---------------------------------------------- //
// Получить список пользователей, которые сделали заказы только на определенные продукты, для выявления узких мест в покупательских предпочтениях.
// var res = from u in context.Users
//           join o in context.Orders on u.Id equals o.UserId
//           join oi in context.OrderItems on o.Id equals oi.OrderId
//           join p in context.Products on oi.ProductId equals p.Id
//           where p.Name == "Laptop"
//           select u;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.Username);
// }


// --------------------------------------- 27 ------------------------------------- //
// Найти пользователей, которые сделали заказы на определенную сумму в определенные даты, чтобы проанализировать сезонные колебания спроса.
// var res = from u in context.Users
//           join o in context.Orders on u.Id equals o.UserId
//           where o.TotalAmount == 12345 && o.OrderDate.Month > DateTime.UtcNow.Month - 1
//           select u;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.Username);
// }


// ---------------------------------- 28 --------------------------------------- //
// Создать отчет о пользователях, которые зарегистрировались за последний месяц, и вывести их данные.
// var res = from u in context.Users
//           where u.CreatedAt.Month > DateTime.UtcNow.Month - 1
//           select u;
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Id + " " + r.CreatedAt);
// }



// --------------------------------- 29 ---------------------------------------- //
// Подсчитать общее количество заказов, которые были отменены, и вывести соответствующую информацию о пользователях.
// var res = from u in context.Users
//           join o in context.Orders on u.Id equals o.UserId
//           where o.IsDeleted == true
//           group o by u.Username into g
//           select new
//           {
//               Name = g.Key,
//               Count = g.Count()
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name + " " + r.Count);
// }


// -------------------------------- 30 --------------------------------------------- //
// Найти все товары, которые были заказаны более 10 раз, и вывести их названия и количество заказов.
// var res = from p in context.Products
//           join oi in context.OrderItems on p.Id equals oi.ProductId
//           group oi by p.Name into g
//           where g.Count() > 10
//           select new
//           {
//               Name = g.Key,
//               Count = g.Count()
//           };
// foreach (var r in res)
// {
//     System.Console.WriteLine(r.Name + " " + r.Count);
// }