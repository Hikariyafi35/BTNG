// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("operator aritmatika");
        var a = 10;
        var b = 5;

        var hasil = a+b;
        var hasil1 = a-b;
        var hasil2 = a*b;
        var hasil3 = a/b;
        var hasil4 = a%3;


        Console.WriteLine(hasil);
        Console.WriteLine(hasil1);
        Console.WriteLine(hasil2);
        Console.WriteLine(hasil3);
        Console.WriteLine(hasil4);
        
        Console.WriteLine("operator penugasan");

        a +=10;
        Console.WriteLine(a);
        a -=10;
        Console.WriteLine(a);
        a *=10;
        Console.WriteLine(a);
        a /=10;
        Console.WriteLine(a);
        a %=3;
        Console.WriteLine(a);

        Console.WriteLine("decrement");
        Console.WriteLine(a);
        Console.WriteLine(++a);
        Console.WriteLine(a);
        Console.WriteLine("increment");
        Console.WriteLine(b);
        Console.WriteLine(b++);
        Console.WriteLine(b);

        Console.WriteLine("Operator perbandingan");
        if(b==6){ //>,<,>=,<=
            Console.WriteLine("benar");
        }else{
            Console.WriteLine("salah");
        }

        Console.WriteLine("operator logika");

        if(a>1 && b<10){
            Console.WriteLine(true);
        }else{
            Console.WriteLine(false);
        }
        if(a>1 || b<10){
            Console.WriteLine(true);
        }else{
            Console.WriteLine(false);
        }
        if(a!=10){
            Console.WriteLine(true);
        }else{
            Console.WriteLine(false);
        }

        Console.WriteLine("Array");
        string[] divisi = {"web","mobile","game","multimedia","jaringan"};
        Console.WriteLine(divisi[0]);
        Console.WriteLine(divisi[1]);
        Console.WriteLine(divisi[2]);
        Console.WriteLine(divisi[3]);
        Console.WriteLine(divisi[4]);

        Console.WriteLine("array 2d");

        int[,] numbers = {{1,2,3},{4,5,6,}};

        Console.WriteLine(numbers[0,1]);
        Console.WriteLine(numbers[1,1]);

        Console.WriteLine("array 3d");
        int[,,] angka = {{{1,2,3},{4,5,6}},{{7,8,9},{10,11,12}}};

        Console.WriteLine(angka[0,0,0]);
        Console.WriteLine(angka[1,1,2]);

        Console.WriteLine("list");

        var nama = new List<string> {"games","mobile","web"};
        for (int i = 0; i< nama.Count; i++){
            Console.WriteLine(nama[i]+ " ");
        }
        Console.WriteLine("Pengkondisian");
        //if else
        int c = 5;
        if(4>c){
            Console.WriteLine("Benar");
        }else{
            Console.WriteLine("salah");
        }
        var nilai = 80;
        //else if
        if(nilai>=90){
            Console.WriteLine("anda dapat A");
        }else if(nilai>=85){
            Console.WriteLine("anda mendapat ab");
        }
        else if(nilai>=80){
            Console.WriteLine("anda mendapat b");
        }
        else if(nilai>=70){
            Console.WriteLine("anda mendapat bc");
        }else{
            Console.WriteLine("dapat c");
        }

        Console.WriteLine("Switch");
        switch(nilai){
            case>95:
            Console.WriteLine("Memuaskan");
            break;
            case>=85:
            Console.WriteLine("Baik");
            break;
            case>=75:
            Console.WriteLine("Mantap");
            break;
            default:
            Console.WriteLine("kurang");
            break;
        }

        Console.WriteLine("Tenary Option");

        int angka1 = 10;
        string total = (angka1 % 2== 0 )?"genap" :"ganjil";
        Console.WriteLine(total);

        Console.WriteLine("Perulangan");
        for(int i = 0; i< 5; i++){
            Console.WriteLine("perulanagn i ke "+i);
        }
        int d = 1;
        while(d<10){
            Console.WriteLine("perulangan d ke "+d);
            d++;
        }
        do{
            Console.WriteLine("perulangan d ke "+d);
            d++;
        }while(d<10);
        int g =0;
        int [] angka2 = new int[5] {1,2,3,4,5};
        foreach (int f in angka2)
        {
            Console.WriteLine("ini adalah isi array urut dari indeks ke "+ g++ + " yaitu "+ f);
        }

        Console.WriteLine("Break & continue");

        for(int i = 0;i <10;i++){
            Console.WriteLine("perulangan ke "+i);
            if(i==5){
                break;
            }
        }
        for (int i = 0;i<10;i++){
            if(i%2 == 0){
                continue;
            }
            Console.WriteLine(i);
        }
        Console.WriteLine("Function");
        
        Tampil();
        int show = Return();
        Console.WriteLine(show);
        int totalDamage = counter(10);
        Console.WriteLine(totalDamage);
    }
    public static void Tampil(){
         Console.WriteLine("Game");   
    }
    public static int Return(){
         return 5;   
    }
    public static int counter(int damage){
         return damage+5;   
    }

}
