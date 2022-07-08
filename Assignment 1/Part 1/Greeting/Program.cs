DateTime moment = DateTime.Now; int hour = moment.Hour;
if (hour < 12){
    Console.WriteLine("Good morning");
}
else if (hour >= 12 && hour < 17){
    Console.WriteLine("Good afternoon");
}
else if (hour >= 17 && hour < 21){
    Console.WriteLine("Good evening");
}
else{
    Console.WriteLine("Good night");
}