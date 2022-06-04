
using System;


namespace DataStructure{

    class Program{
        static void Main (string[] args){

            int secimListe = menu();
            while(secimListe != 0){

                switch(secimListe){
                    case 1:
                        tekYönlüListe();
                        break;
                    case 2:
                        ciftYönlüListe();
                        break;
                    case 3:
                        tekYönlüDaireselListe();
                        break;
                    case 4:
                        ciftYönlüDaireselListe();
                        break;
                    case 5:
                        stack();
                        break;
                    case 6:
                        queue();
                        break;
                    case 7:
                        tree();
                        break;
                    default:
                        System.Console.WriteLine("Yanlış işlem girdiniz !");
                        break;
                }
                secimListe = menu();
                System.Console.WriteLine();
            }         
        }

        public static int menuTree(){
             int secim;
            System.Console.WriteLine("\n1- ekle (En Queue)");
            System.Console.WriteLine("2- çıkar (De Queue)");
            System.Console.WriteLine("3- PreOrder");
            System.Console.WriteLine("4- InOrder");
            System.Console.WriteLine("5- PostOrder");
            System.Console.WriteLine("6- Size");
            System.Console.WriteLine("7- Yukseklik");
            System.Console.WriteLine("8- Max Value");
            System.Console.WriteLine("9- Min Value");
            

            System.Console.WriteLine("0- bir üst menüye dön ");

            System.Console.Write("\nİşlem seçiniz : ");
            secim = int.Parse(Console.ReadLine() );
            return secim;

        }
        public static void tree(){
             int sayi , indis;
            Tree tree = new Tree();
            int secim = menuTree();


            while(secim != 0){

                switch(secim){
                    case 1:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse(Console.ReadLine());
                        tree.root = tree.insert(tree.root, sayi);
                        break;
                    case 2:
                        break;

                    case 3:
                        tree.preOrder(tree.root);
                        break;
                    case 4:
                        tree.inOrder(tree.root);
                        break;
                    case 5:
                        tree.postOrder(tree.root);
                        break;
                    case 6:
                        System.Console.WriteLine("Düğüm Sayısı: " + tree.size(tree.root));
                        break;
                    case 7:
                        System.Console.WriteLine("Ağaç yükeskliği : "+ tree.yukseklik(tree.root));
                        break;
                    case 8:
                        tree.max(tree.root);
                        break;
                    case 9:
                        tree.min(tree.root);
                        break;
                    default:
                        System.Console.WriteLine("geçersiz işlem !");
                        break;
                }
                
                secim = menuTree();
                System.Console.WriteLine();

        }
        }
        public static int  menuListeStack(){
            int secim;
            System.Console.WriteLine("\n1- ekle (push)");
            System.Console.WriteLine("2- çıkar (pop)");
            System.Console.WriteLine("0- bir üst menüye dön ");

            System.Console.Write("\nİşlem seçiniz : ");
            secim = int.Parse(Console.ReadLine() );
            return secim;

        }
        public static int menuListeQueue(){
             int secim;
            System.Console.WriteLine("\n1- ekle (En Queue)");
            System.Console.WriteLine("2- çıkar (De Queue)");
            System.Console.WriteLine("0- bir üst menüye dön ");

            System.Console.Write("\nİşlem seçiniz : ");
            secim = int.Parse(Console.ReadLine() );
            return secim;

        }
        public static void queue(){
             int sayi , indis;
            Queue queue = new Queue();
            int secim = menuListeStack();


            while(secim != 0){

                switch(secim){
                    case 1:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse(Console.ReadLine());
                        queue.enQueue(sayi);
                        break;
                    case 2:
                        queue.deQueue();
                        break;
                    default:
                        System.Console.WriteLine("geçersiz işlem !");
                        break;
                }
                
                queue.print();
                secim = menuListeQueue();
                System.Console.WriteLine();

            }
            

        }
        public static void  stack(){
            int sayi , indis;
            Stack stack = new Stack();
            int secim = menuListeStack();


            while(secim != 0){

                switch(secim){
                    case 1:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse(Console.ReadLine());
                        stack.push(sayi);
                        break;
                    case 2:
                        stack.pop();
                        break;
                    default:
                        System.Console.WriteLine("geçersiz işlem !");
                        break;
                }
                
                stack.print();
                secim = menuListeStack();
                System.Console.WriteLine();

            }

        }
        public static void ciftYönlüListe(){
            int sayi , indis;
            CiftYönlüListe liste = new CiftYönlüListe();
            int secim = menuListe();


            while(secim != 0){

                switch(secim){
                    case 1:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse(Console.ReadLine());
                        liste.basaEkle(sayi);
                        break;
                    case 2:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse(Console.ReadLine());
                        liste.sonaEkle(sayi);
                        break;
                    case 3:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse( Console.ReadLine() );
                        System.Console.Write("indis: ");
                        indis = int.Parse( Console.ReadLine() );
                        liste.arayaEkle(indis, sayi);
                        break;
                    case 4:
                        liste.bastanSil();
                        break;
                    case 5:
                        liste.sondanSil();
                        break;
                    case 6:
                        System.Console.Write("indis: ");
                        indis = int.Parse(Console.ReadLine());
                        liste.aradanSilme(indis);
                        break;
                    default:
                        System.Console.WriteLine("geçersiz işlem !");
                        break;
                }
                
                liste.ekranaYaz();
                secim = menuListe();
                System.Console.WriteLine();

            }
            
        }
        public static void ciftYönlüDaireselListe(){
            int sayi , indis;
            CiftYönlüDaireselListe liste = new CiftYönlüDaireselListe();
            int secim = menuListe();


            while(secim != 0){

                switch(secim){
                    case 1:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse(Console.ReadLine());
                        liste.basaEkle(sayi);
                        break;
                    case 2:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse(Console.ReadLine());
                        liste.sonaEkle(sayi);
                        break;
                    case 3:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse( Console.ReadLine() );
                        System.Console.Write("indis: ");
                        indis = int.Parse( Console.ReadLine() );
                        liste.arayaEkle(indis, sayi);
                        break;
                    case 4:
                        liste.bastanSil();
                        break;
                    case 5:
                        liste.sondanSil();
                        break;
                    case 6:
                        System.Console.Write("indis: ");
                        indis = int.Parse(Console.ReadLine());
                        liste.aradanSil(indis);
                        break;
                    default:
                        System.Console.WriteLine("geçersiz işlem !");
                        break;
                }
                
                liste.ekranaYaz();
                secim = menuListe();
                System.Console.WriteLine();

            }
            
        }


        public static void tekYönlüListe(){
            int sayi, indis;
            TekYönlüListe liste = new TekYönlüListe();
            int secim = menuListe();
            while(secim != 0){
                switch(secim){
                    case 1: 
                        System.Console.Write("sayı: ");
                        sayi = int.Parse( Console.ReadLine() );
                        liste.basaEkle(sayi);
                        break;

                    case 2:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse( Console.ReadLine() );
                        liste.sonaEkle(sayi);
                        break;

                    case 3:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse( Console.ReadLine() );
                        System.Console.Write("indis: ");
                        indis = int.Parse( Console.ReadLine() );
                        liste.arayaEkle(indis,sayi);
                        break;
                    case 4:
                        liste.bastanSil();
                        break;
                    case 5:
                        liste.sondanSil();
                        break;
                    case 6:
                        System.Console.WriteLine("indis: ");
                        indis = int.Parse( Console.ReadLine());
                        liste.aradanSil(indis);
                        break;
                    default:
                        System.Console.WriteLine("Hatalı giriş değeri !");
                        break;
                }
                liste.ekranYaz();
                secim = menuListe();
                System.Console.WriteLine();

            }  
        }
        public static void tekYönlüDaireselListe(){
            int sayi, indis;
            TekYönlüDaireselListe liste = new TekYönlüDaireselListe();
            int secim = menuListe();
            while(secim != 0){
                switch(secim){
                    case 1: 
                        System.Console.Write("sayı: ");
                        sayi = int.Parse( Console.ReadLine() );
                        liste.basaEkle(sayi);
                        break;

                    case 2:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse( Console.ReadLine() );
                        liste.sonaEkle(sayi);
                        break;

                    case 3:
                        System.Console.Write("sayı: ");
                        sayi = int.Parse( Console.ReadLine() );
                        System.Console.Write("indis: ");
                        indis = int.Parse( Console.ReadLine() );
                        liste.arayaEkle(indis,sayi);
                        break;
                    case 4:
                        liste.bastanSil();
                        break;
                    case 5:
                        liste.sondanSil();
                        break;
                    case 6:
                        System.Console.Write("indis: ");
                        indis = int.Parse( Console.ReadLine());
                        liste.aradanSil(indis);
                        break;
                    default:
                        System.Console.WriteLine("Hatalı giriş değeri !");
                        break;
                }
                liste.ekranaYaz();
                secim = menuListe();
                System.Console.WriteLine();

            }  
        }
        public static int menu(){
            System.Console.WriteLine("1- Tek Yönlü Liste");
            System.Console.WriteLine("2- Cift Yönlü Liste");
            System.Console.WriteLine("3- Tek Yönlü Dairesel Liste");
            System.Console.WriteLine("4- Çift Yönlü Dairesel Liste");
            System.Console.WriteLine("5- Stack  (Yığıt/Yığın)");
            System.Console.WriteLine("6- Queue  (Kuyruk)");
            System.Console.WriteLine("7- Tree (Ağaç)");
            System.Console.WriteLine("0- Programı Sonlandır");

            System.Console.Write("Yapmak istediğiniz işlemi seçiniz: ");
            int secim = int.Parse( Console.ReadLine());
            return secim;
        }
        public static int menuListe(){
            int secim;
            System.Console.WriteLine("\n1- basa ekle ");
            System.Console.WriteLine("2- sona ekle ");
            System.Console.WriteLine("3- araya ekle ");
            System.Console.WriteLine("4- bastan sil ");
            System.Console.WriteLine("5- sondan sil ");
            System.Console.WriteLine("6- aradan sil");
            System.Console.WriteLine("0- bir üst menüye dön ");

            System.Console.Write("\nİşlem seçiniz : ");
            secim = int.Parse(Console.ReadLine() );
            return secim;
        }
    }

}
