using System.Security.Cryptography.X509Certificates;

class Fighter: SecondAccess, ThirdAccess{

    public void kick(){
        System.Console.WriteLine("There is a kick to the face");
    }

    public void punch(){
        System.Console.WriteLine("There is a right hook, and a left hook");
    }

    public void combo(){
        System.Console.WriteLine("THats a beautiful combo");
    }

    public void duck() {
        System.Console.WriteLine("Opponent ducks");
    }

    public void slip(){
        System.Console.WriteLine("The opponent slips");
    }

    public void knockOut(){
        System.Console.WriteLine("Down goes te opponent, it is a knockout");
    }

    public void connects(){
        System.Console.WriteLine("He connects with an upper cut");
    } 
}