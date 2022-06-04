namespace DataStructure
{
    public class TekYönlüListe
    {
        Node? head;

        public TekYönlüListe()
        {
            head = null;  
        }
        
        public  void sonaEkle(int data){

            Node eleman = new Node(data);

            if(head == null){
                head = eleman;
                System.Console.WriteLine("Basa eleman eklendi !");
            }else{
                Node temp = head;
                while(temp.next != null){
                    temp = temp.next;
                }
                temp.next = eleman;
                System.Console.WriteLine("Sona eleman eklendi !");
                
            }
        }

        public  void basaEkle(int data){
        Node eleman = new Node(data);

        if(head == null){
            head = eleman;
            System.Console.WriteLine("İlk eleman eklendi !");
        }else{
            eleman.next = head;
            head = eleman;
            System.Console.WriteLine("Basa elaman eklendi !");
        }
    }

    public void ekranYaz(){
        Node temp= head;

        System.Console.Write("bas -> ");
        if (head == null){
            System.Console.WriteLine("Liste bomboş !");
        }else{
            while(temp.next != null){
            System.Console.Write(temp.data+ "-> ");
            temp = temp.next;
            } 
            System.Console.Write(temp.data+ " son.");
        }
    }

    public void bastanSil(){
        if(head == null){
            System.Console.WriteLine("Liste bomboş !");
        }else{
            head = head.next;
            System.Console.WriteLine("Baştan silme işlemi başarılı bir şekilde gerçekleştirildi !");
        }
    }

    public void sondanSil(){

        if(head == null){    
            System.Console.WriteLine("Liste bomboş !");
        }
        else if(head.next == null){
            head = null;
            System.Console.WriteLine("Listede kalan son eleman da silindi !");
        }
        else{
            Node temp = head;
            Node temp2 = temp;
            while(temp.next != null){ 
                temp2 = temp;         
                temp = temp.next;
            }
            temp2.next = null;
            System.Console.WriteLine("Sondan silme işlemi başarılı bir şekilde gerçekleştirlidi !");
        }

    }
    public void arayaEkle(int indis, int data){
        
        Node eleman = new Node(data);
        bool sonuc  = false;


        if(head == null && indis == 0){
            sonuc = true;
            head= eleman;
            System.Console.WriteLine("Elaman başa eklendi !");
        }
        else if(indis == 0){
            basaEkle(data);
            sonuc = true;
        }
        else {
            Node temp = head;
            Node temp2 = temp;
            int i =0;

            while(temp.next != null){
                
                temp2 = temp;
                temp = temp.next;
                i++;

                if(i == indis){
                    sonuc= true;
                    temp2.next = eleman;
                    eleman.next = temp; 
                    i++;
                    break;

                }
               
            }
            if((i+1) == indis){
                sonuc = true;
                sonaEkle(data);
            }
        }
        if(sonuc == false){
            System.Console.WriteLine("Hatalı indis numarası!");
        }
    }

    public void aradanSil(int indis){

        bool sonuc = false;
        
        if(head == null){
            System.Console.WriteLine("Liste bomboş !");
        }
        else if(head.next == null && indis == 0){
            sonuc = true;
            head  = null;
            System.Console.WriteLine("ilk eleman başarılı bir şekilde silindi !");
        }
        else if(head.next != null && indis ==0 ){
            sonuc = true;
            bastanSil();
            System.Console.WriteLine("elaman silindi !");
        }
        else{
            Node temp = head;
            Node temp2 = temp;
            int i =0;

            while(temp.next != null){
                if(i == indis){
                    sonuc = true;
                    temp2.next = temp.next;
                    System.Console.WriteLine("Aradan silme işlemi başarılı bir şekilde gerçekleştirildi !");
                    i++;
                    break;

                }
                temp = temp.next;
                i++;
            }
            if(i == indis){
                sonuc = true;
                temp2.next = null;
                System.Console.WriteLine("sondan elaman silindi !");
            }

        }
        if(sonuc == false){
            System.Console.WriteLine("geçersiz işlem !");
        }
            


        

    }
    }
}