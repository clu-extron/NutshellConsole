//// 12 - Collections

//string[] daysOfWeek =
//{
//    "Monday",
//    "Tuesday",
//    "Wednesday",
//    "Thursday",
//    "Friday",
//    "Saturday",
//    "Sunday"
//};

//foreach (var day in daysOfWeek)
//{
//    //Console.WriteLine(day);
//}

//// 零索引 0-indexed
////Console.WriteLine(daysOfWeek[0]);

//// 固定长度
//string[] daysOfWeek2 = new string[7];
//daysOfWeek2[0] = "Monday";
//daysOfWeek2[1] = "Tuesday";
//daysOfWeek2[2] = "Wednesday";
//daysOfWeek2[3] = "Thursday";
//daysOfWeek2[4] = "Friday";
//daysOfWeek2[5] = "Saturday";
//daysOfWeek2[6] = "Sunday";

//// 12-4 List 列表
//List<string> daysOfWeek3 = new()
//{
//    "Monday",
//    "Tuesday",
//    "Wednesday",
//    "Thursday",
//    "Friday",
//    "Saturday",
//    "Sunday"
//};

////Console.WriteLine(daysOfWeek3.Count);

//daysOfWeek3.Add("Monday");

////Console.WriteLine(daysOfWeek3.Count);

//// 12-5
//var daysOfWeek4 = new List<string>(daysOfWeek3);
//var daysOfWeek5 = new List<string>(daysOfWeek);
//var daysOfWeek6 = new List<string>(7);
////Console.WriteLine($"{daysOfWeek6.Count} / {daysOfWeek6.Capacity}");

//daysOfWeek6.Add("Monday");
//daysOfWeek6.Add("Tuesday");
//daysOfWeek6.Add("Wednesday");
//daysOfWeek6.Add("Thursday");
//daysOfWeek6.Add("Friday");
//daysOfWeek6.Add("Saturday");
//daysOfWeek6.Add("Sunday");
////Console.WriteLine($"{daysOfWeek6.Count} / {daysOfWeek6.Capacity}");

//daysOfWeek6.Add("Monster");
////Console.WriteLine($"{daysOfWeek6.Count} / {daysOfWeek6.Capacity}");

//List<string> zodiacList = new List<string>
//{
//    "Aries",
//    "Taurus",
//    "Gemini",
//    "Cancer",
//    "Leo",
//    "Virgo",
//    "Libra",
//    "Scorpio",
//    "Sagittarius",
//    "Capricorn",
//    "Aquarius",
//    "Pisces"
//};

////Console.WriteLine($"{zodiacList.Count} / {zodiacList.Capacity}");

//// Add Range
//zodiacList.AddRange(daysOfWeek);
////Console.WriteLine($"{zodiacList.Count} / {zodiacList.Capacity}");

//// InsertRange
//zodiacList.InsertRange(1, daysOfWeek);
////Console.WriteLine($"{zodiacList.Count} / {zodiacList.Capacity}");
////foreach (var item in zodiacList)
////{
////    Console.WriteLine(item);
////}

////Console.WriteLine(string.Join(", ", zodiacList));

//// 删除数据 RemoveAt RemoveRange
//daysOfWeek6.RemoveAt(0);
////Console.WriteLine(string.Join(", ", daysOfWeek6));

//daysOfWeek6.RemoveAt(2);
////Console.WriteLine(string.Join(", ", daysOfWeek6));

//daysOfWeek6.RemoveRange(2, 4);
////Console.WriteLine(string.Join(", ", daysOfWeek6));

////Console.WriteLine(string.Join(", ", zodiacList));
//zodiacList.RemoveAll(i => i.Contains(("us")));
////Console.WriteLine("---------------------------");
////Console.WriteLine("---------------------------");
////Console.WriteLine(string.Join(", ", zodiacList));

//// 12-6 读取数据
//List<string> daysOfWeek7 = new()
//{
//    "Monday",
//    "Tuesday",
//    "Wednesday",
//    "Thursday",
//    "Friday",
//    "Saturday",
//    "Sunday"
//};

//var a = daysOfWeek7.Count;
////Console.WriteLine(a);

//var b = daysOfWeek7.Capacity;
////Console.WriteLine(b);

//// 索引器
//var c = daysOfWeek7[3];
////Console.WriteLine(c);

//// 迭代器
//var enumerator = daysOfWeek7.GetEnumerator();

//Console.WriteLine(enumerator.Current);
//while (enumerator.MoveNext())
//{
//    Console.WriteLine(enumerator.Current);
//}

//foreach (var day in daysOfWeek7)
//{
//    Console.WriteLine(day);
//}
