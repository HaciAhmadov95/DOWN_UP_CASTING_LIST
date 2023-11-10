#region Homeworks

//using List_Casting_Practice;
//using List_Casting_Practice.Models;

//Generics <Product> products = new Generics<Product>();

//products.Add(new Product { Id = 1, Name = "Lenovo", Price = 1200 });
//products.Add(new Product { Id = 2, Name = "Acer", Price = 2000 });
//products.Add(new Product { Id = 3, Name = "Asus", Price = 2200});



//products.Delete(3);



//var result = products.ShowAll();

//foreach (var item in result)
//{
//    Console.WriteLine($"{item.Name} - {item.Price}");
//}

////var result = products.GetById(2);

////Console.WriteLine(result.Name);


using List_Casting_Practice.Controller;
using List_Casting_Practice.Exceptions;
using List_Casting_Practice.Models;

//try
//{
//	int num = 5;
//	int factorial = 1;

//	if (num < 0)
//	{
//		throw new LessThanZeroException();
//	}
//		for(int i = 1; i <= num; i++)
//		{
//			factorial *= i;
//		}
//        Console.WriteLine(factorial);


//}
//catch (Exception ex)
//{

//    Console.WriteLine(ex.Message);

//}

#endregion


//Animal animal = new Animal();

//Fish fish1 = new Fish();    

//Bird bird = new Bird();

//Animal animal1 = fish1;

//Animal animal2 = bird;

//Bird bird2 = (Bird) animal2;

////animal1.Sound();

////fish1.Sound();




//Animal[] datas = { animal1, animal2, fish1, bird2 };

//foreach (var item in datas)
//{
//    item.Name = "xxx";
//    Console.WriteLine(item.Name);
//}

//int num1 = 5;
//object obj = num1;

//int num2 = (int) obj;



//bool isMarried = false;




//object data = isMarried;
//bool test = (bool)data;


//string name = "test";
//object data2 = name;

//string name2 = data2.ToString();



//byte num1 = 5;
//int num2 = num1;

//int a1 = 200;
//byte a2 = (byte) a1;

//Console.WriteLine(a2);


//Bird bird = new Bird();

//Fish fish = new Fish();

//Animal animal1 = new Bird();

//Animal animal2 = new Fish();



//object[] datas = { 1, 2, 3, bird, "salam", fish, animal1, 100, animal2 };

//foreach (var data in datas)
//{
//    if(data is Animal)
//    {
//        ((Animal)data).Name = "xxx";
//        Console.WriteLine(((Animal)data).Name);
//    }

//}

//foreach (var data in datas)
//{
//    Animal animal = data as Animal;
//    if (animal != null)
//    {
//        animal.Name = "Cow";
//        Console.WriteLine();
//    }
//}




//List <int> nums = new();


//nums.Add(1);
//nums.Add(2);
//nums.Add(3);


//List<int> nums2 = new();

//nums2.Add(4);
//nums2.Add(5);

//nums.AddRange(nums2);

//Console.WriteLine(nums[2]);
//Console.WriteLine(nums.Count);

//foreach (var item in nums)

//Console.WriteLine(item);





//List<string> names = new List<string>() { "Haci", "Ali", "Elnur" };

// for (int i = 0; i < names.Count; i++)
//{
//    Console.WriteLine(names[i]);
//}


//List<string> emails = new List<string>() { "t@gmail.com", { "a@gmail.com" } };

//static void CheckEmail(string email, List <string> emails)
//{
//    if (emails.Contains(email))
//    {
//        Console.WriteLine("yes");
//    }
//    else 
//    { 
//        Console.WriteLine("no");
//    }  
//}


//////CheckEmail("t@gmail.com",emails);

//List<Product> Products = new List<Product>();

//Products.Add(new Product { Id = 1, Name = "Iphone", Price = 200 });

//Products.Add(new Product { Id = 2, Name = "Samsung", Price = 300 });

//Products.Add(new Product { Id = 3, Name = "Nokia", Price = 400 });


//foreach (var item in Products)
//{
//    Console.WriteLine(item.Name);
//}


//static List<Product> Search(string str,List<Product> products)
//{
//    var datas = products.FindAll(x => x.Name.Contains(str));
//    return products.Where(m => m.Name.Contains (str)).ToList();

//}



//List <int> nums = new List <int> () {1,2,3,4,5};    

//for (int i = 0;i <= nums.Count; i++)
//{
//    if (i == 3)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}






// List <int> nums = new List <int> () {1,2,3,4,5};

//for (int i = 0;i < nums.Count; i++)
//{
//    int index = nums.IndexOf (4);

//    if(i <= index)
//    {
//        Console.WriteLine(nums[i]);
//    }
//}

ProductController productController = new ProductController();

productController.GetAll();

productController.GetById();

productController.Sorting();