namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;

public class Patent
{
    // 专利申请标题
    public string Title { get; }

    // 专利的正式发布日期
    public string YearOfPublication { get; }

    // 分配给专利的唯一编号
    public string? ApplicationNumber { get; set; }

    public long[] InventorIds { get; }

    public Patent(
        string title, string yearOfPublication, long[] inventorIds)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        YearOfPublication = yearOfPublication ??
            throw new ArgumentNullException(nameof(yearOfPublication));
        InventorIds = inventorIds ??
            throw new ArgumentNullException(nameof(inventorIds));
    }

    public override string ToString()
    {
        return $"{Title} ({YearOfPublication})";
    }

}

public class Inventor
{
    public long Id { get; }
    public string Name { get; }
    public string City { get; }
    public string State { get; }
    public string Country { get; }

    public Inventor(
        string name, string city, string state, string country, int id)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        City = city ?? throw new ArgumentNullException(nameof(city));
        State = state ?? throw new ArgumentNullException(nameof(state));
        Country = country ?? throw new ArgumentNullException(nameof(country));
        Id = id;
    }

    public override string ToString()
    {
        return $"{Name} ({City}, {State})";
    }

}

public static class PatentData
{
    public static readonly Inventor[] Inventors = new Inventor[]
    {
        new(
    "本杰明·富兰克林", "费城",
    "PA", "美国", 1),
        new(
    "奥维尔·莱特", "基蒂霍克",
    "NC", "美国", 2),
        new(
    "威尔伯·莱特", "基蒂霍克",
    "NC", "美国", 3),
        new(
    "塞缪尔·莫尔斯", "纽约",
    "NY", "美国", 4),
        new(
    "乔治·斯蒂芬森", "怀拉姆",
    "诺森伯兰", "英国", 5),
        new(
    "约翰·迈克利斯", "芝加哥",
    "IL", "美国", 6),
        new(
    "玛丽·菲尔普斯·雅各布", "纽约",
    "NY", "美国", 7)
    };

    public static readonly Patent[] Patents = new Patent[]
    {
        new("双焦点眼镜","1784", inventorIds: new long[] { 1 }),
        new("留声机", "1877", inventorIds: new long[] { 1 }),
        new("活动电影机", "1888", inventorIds: new long[] { 1 }),
        new("电报", "1837", inventorIds: new long[] { 4 }),
        new("飞机", "1903", inventorIds: new long[] { 2, 3 }),
        new("蒸汽机车", "1815", inventorIds: new long[] { 5 }),
        new("液滴沉积装置", "1989", inventorIds: new long[] { 6 }),
        new("无背式胸罩", "1914", inventorIds: new long[] { 7 })
    };
}

//namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;

//public class Patent
//{
//    // Title of the published application
//    public string Title { get; }

//    // The date the application was officially published
//    public string YearOfPublication { get; }

//    // A unique number assigned to published applications
//    public string? ApplicationNumber { get; set; }

//    public long[] InventorIds { get; }

//    public Patent(
//        string title, string yearOfPublication, long[] inventorIds)
//    {
//        Title = title ?? throw new ArgumentNullException(nameof(title));
//        YearOfPublication = yearOfPublication ?? 
//            throw new ArgumentNullException(nameof(yearOfPublication));
//        InventorIds = inventorIds ?? 
//            throw new ArgumentNullException(nameof(inventorIds));
//    }

//    public override string ToString()
//    {
//        return $"{ Title } ({ YearOfPublication })";
//    }

//}

//public class Inventor
//{
//    public long Id { get; }
//    public string Name { get; }
//    public string City { get; }
//    public string State { get; }
//    public string Country { get; }

//    public Inventor(
//        string name, string city, string state, string country, int id)
//    {
//        Name = name ?? throw new ArgumentNullException(nameof(name));
//        City = city ?? throw new ArgumentNullException(nameof(city));
//        State = state ?? throw new ArgumentNullException(nameof(state));
//        Country = country ?? throw new ArgumentNullException(nameof(country));
//        Id = id;
//    }

//    public override string ToString()
//    {
//        return $"{ Name } ({ City }, { State })";
//    }

//}

//public static class PatentData
//{
//    public static readonly Inventor[] Inventors = new Inventor[]
//    {
//        new(
//            "Benjamin Franklin", "Philadelphia",
//            "PA", "USA", 1),
//        new(
//            "Orville Wright", "Kitty Hawk",
//            "NC", "USA", 2),
//        new(
//            "Wilbur Wright", "Kitty Hawk",
//            "NC", "USA", 3),
//        new(
//            "Samuel Morse", "New York",
//            "NY", "USA", 4),
//        new(
//            "George Stephenson", "Wylam",
//            "Northumberland", "UK", 5),
//        new(
//            "John Michaelis", "Chicago",
//            "IL", "USA", 6),
//        new(
//            "Mary Phelps Jacob", "New York",
//            "NY", "USA", 7)
//    };

//    public static readonly Patent[] Patents = new Patent[]
//    {
//        new("Bifocals","1784", inventorIds: new long[] { 1 }),
//        new("Phonograph", "1877", inventorIds: new long[] { 1 }),
//        new("Kinetoscope", "1888", inventorIds: new long[] { 1 }),
//        new("Electrical Telegraph", "1837", inventorIds: new long[] { 4 }),
//        new("Flying Machine", "1903", inventorIds: new long[] { 2, 3 }),
//        new("Steam Locomotive", "1815", inventorIds: new long[] { 5 }),
//        new("Droplet Deposition Apparatus", "1989", inventorIds: new long[] { 6 }),
//        new("Backless Brassiere", "1914", inventorIds: new long[] { 7 })
//    };
//}
