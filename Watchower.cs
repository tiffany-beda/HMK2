/*using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Watchower
{
public class Watchower
{
private double x_coord = -1000.0;
private double y_coord = -1000.0;

 public double X_coord 
 {
    get{ return this.x_coord;}
    set{this.x_coord = value;}
 }
 public double Y_coord
 {
    get{ return this.y_coord;}
    set{this.y_coord = value;}
 }
 public Watchower (): this(-1000,-1000){}
 public Watchower (double _X_coord,double _Y_coord)
 {
    this.X_coord = _X_coord;
    this.Y_coord = _Y_coord;

 }
 public void GetDirections (double _X_coord,double _Y_coord)
 {
        if (_X_coord < 0  && _Y_coord > 0)  Console.WriteLine("The enemy is to the north west!");
        if (_X_coord == 0 && _Y_coord > 0)  Console.WriteLine("The enemy is to the north!");
        if (_X_coord > 0  && _Y_coord > 0)  Console.WriteLine("The enemy is to the north east!");
        if (_X_coord < 0  && _Y_coord == 0) Console.WriteLine("The enemy is to the west!");
        if (_X_coord == 0 && _Y_coord == 0) Console.WriteLine("The enemy is here!");
        if (_X_coord > 0  && _Y_coord == 0) Console.WriteLine("The enemy is to the east!");
        if (_X_coord < 0  && _Y_coord < 0)  Console.WriteLine("The enemy is to the south west!");
        if (_X_coord == 0 && _Y_coord < 0)  Console.WriteLine("The enemy is to the south!");
        if (_X_coord > 0  && _Y_coord < 0)  Console.WriteLine("The enemy is to the south east!");
 }
public override string ToString ()
{
    return $"Enemy coordinates:({X_coord},{Y_coord})";
}

public static void Main (string []args)
{
 Console.WriteLine ("Enter the coordonates of the enemy:");

  double x = Convert.ToInt32(Console.ReadLine());
  double y = Convert.ToInt32(Console.ReadLine());

 Watchower enemy1 = new Watchower(x,y);


 Console.WriteLine (enemy1);
 enemy1.GetDirections(x,y);
 

}
}
}
*/