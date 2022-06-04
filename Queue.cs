namespace DataStructure
{
    public class Queue
    {
        Node? front;
        Node? rear;

        public Queue()
        {
            front = null;
            rear = null;
        }


        public void enQueue(int data){
            Node eleman = new Node(data);

            if(front == null){
                front = rear = eleman;
                System.Console.WriteLine("Kuyruk oluşturuldu, ilk eleman eklendi !");
            }else{
                rear.next = eleman;
                rear = eleman;
                System.Console.WriteLine("kuyruğun sonuna eleman eklendi !");
            }


        }

        public int deQueue(){
            if(front == null){
                System.Console.WriteLine("Kuyruk boş !");
                return -1;
            }else{
                int data = front.data;
                front = front.next;
                System.Console.WriteLine(data+ " kuyruktan çıkartıldı ");
                return data;
            }

        }

        public void print(){
            if(front == null){
                System.Console.WriteLine("kuyrukta eleman yok !");
            }else{

                Node temp = front;
                System.Console.Write("bas -> ");

                while(temp != rear){
                    System.Console.Write(temp.data+" <-");
                    temp = temp.next;
                }
                System.Console.WriteLine(temp.data+ " son.");
            }
        }
    }
}