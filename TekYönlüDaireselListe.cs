namespace DataStructure
{
    public class TekYönlüDaireselListe
    {
        Node? head;
        Node? tail;

        public TekYönlüDaireselListe()
        {
            head = null;
            tail = null;
        }


        public void basaEkle(int data){
            Node eleman = new Node(data);

            if(head == null){
                head = tail = eleman;
                tail.next = head;
                System.Console.WriteLine("ilk elaman eklendi !");
            }else{
                eleman.next = head;
                head = eleman;
                tail.next = head;
                System.Console.WriteLine("başa eleman eklendi !");
            }
        }



         public void sonaEkle(int data){
            Node eleman = new Node(data);

            if(head == null){
                head = tail = eleman;
                tail.next = head;
                System.Console.WriteLine("ilk elaman eklendi !");
            }else{

                tail.next = eleman;
                tail = eleman;
                tail.next = head;
                System.Console.WriteLine("sona eleman eklendi !");
            }
        }
        public void arayaEkle(int indis ,int data){
            Node eleman = new Node(data);
            bool sonuc = false;

            if(head == null && indis == 0){
                head = tail =eleman;
                tail.next = head;
                sonuc = true;
                System.Console.WriteLine("ilk eleman eklendi !");
            }else if(head != null && indis == 0){
                basaEkle(data);
                sonuc = true;
            }else{
                Node temp = head;
                Node temp2 = temp;
                int i = 0;

                while(temp != tail){
                     temp2 = temp;
                    temp = temp.next;  
                    i++;
                   
                    if(i == indis){
                        temp2.next = eleman;
                        eleman.next = temp;
                        sonuc = true;
                        System.Console.WriteLine("araya ekleme yapıldı !");
                        i++;
                        break;
                    }
                   
                }
                if(i == indis){
                    sonaEkle(data);
                    sonuc = true;

                }
                if(sonuc == false){
                    System.Console.WriteLine("Geçersiz işlem girdiniz !");
                }

            }

        }
        public void bastanSil(){

            if(head == null){
                System.Console.WriteLine("Liste boş !");
            }else if(head.next ==head){
                head = tail = null;
                System.Console.WriteLine("listedeki son eleman silindi !");
            }else{
                head = head.next;
                tail.next = head;
              
                System.Console.WriteLine("baştan silme işlemi başarılı !");
            }

        }
        public void sondanSil(){
            if(head == null){
                System.Console.WriteLine("liste boş !");
            }else if(head.next == head){
                head = tail = null;
                System.Console.WriteLine("listedeki son eleamn da silindi !");
            }
            else{
                Node temp= head;

                while(temp.next != tail){
                    temp = temp.next;
                }
                temp.next = null;
                tail = temp;
                temp.next = head;
                System.Console.WriteLine("sondan eleman silindi !");
            }

        }

        public void aradanSil(int indis){
            bool sonuc = false ;
            if(head == null && indis == 0){
                System.Console.WriteLine("Liste boş !");
            }else if(head.next == head && indis == 0 ){
                sonuc = true;
                head = tail = null;
                System.Console.WriteLine("Listedeki son eleman silindi !");
            }else if (head.next != null && indis == 0){
                bastanSil();
                sonuc = true;
            }else{
                Node temp = head;
                Node temp2 = temp;
                int i = 0;
                while(temp != tail){
                   

                    if(i == indis){
                        temp2.next = temp.next;
                        temp2.next.prev = temp.prev;
                        System.Console.WriteLine("aradan eleaman silme işlemi başarılı !");
                        sonuc = true;
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }

                if(i == indis){
                    sondanSil();
                    sonuc = true;
                }

                if(sonuc == false ){
                    System.Console.WriteLine("Hatalı işlem girdiniz !");
                }
            }

        }

         public void ekranaYaz(){

            if(head == null){
                System.Console.WriteLine("Liste boş !");
            }
            else{
                Node temp = head;
                 
                 System.Console.Write("\nbas -> ");
                while(temp != tail){
                    
                    System.Console.Write(temp.data + " -> ");
                    temp = temp.next;
                    
                }

                System.Console.Write(temp.data + " son\n");
            }

           
         }
        
    }
}