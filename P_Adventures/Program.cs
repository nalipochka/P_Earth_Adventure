using P_Adventures;


Console.WriteLine("-----------------------------------------");
World world1 = new World(new DesertWorldFactory());
Console.WriteLine(world1.Title);
world1.PlantLife();
world1.HerbivorusLife();
world1.PredatorLife();
Console.WriteLine("-----------------------------------------");
World world2 = new World(new ForestWorldFactory());
Console.WriteLine(world2.Title);
world2.PlantLife();
world2.HerbivorusLife();
world2.PredatorLife();
Console.WriteLine("-----------------------------------------");
World world3 = new World(new OceanWorldFactory());
Console.WriteLine(world3.Title);
world3.PlantLife();
world3.HerbivorusLife();
world3.PredatorLife();
Console.WriteLine("-----------------------------------------");