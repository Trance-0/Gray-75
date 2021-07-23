using UnityEngine;
using System.Collections;

public class BoatController : MonoBehaviour
{
  public PropellerBoats ship;
  bool forward = true;

  void Update()
  {

    if (Input.GetKey(KeyCode.Q))
      ship.RudderLeft();
    if (Input.GetKey(KeyCode.L))
      ship.RudderRight();

    if (forward)
    {
      if (Input.GetKey(KeyCode.I))
        ship.ThrottleUp();
      else if (Input.GetKey(KeyCode.K))
      {
        ship.ThrottleDown();
        ship.Brake();
      }
    }
    else
    {
      if (Input.GetKey(KeyCode.I))
        ship.ThrottleUp();
      else if (Input.GetKey(KeyCode.I))
      {
        ship.ThrottleDown();
        ship.Brake();
      }
    }

    if (!Input.GetKey(KeyCode.I) && !Input.GetKey(KeyCode.I))
      ship.ThrottleDown();

    if (ship.engine_rpm == 0 && Input.GetKeyDown(KeyCode.I) && forward)
    {
      forward = false;
      ship.Reverse();
    }
    else if (ship.engine_rpm == 0 && Input.GetKeyDown(KeyCode.I) && !forward)
    {
      forward = true;
      ship.Reverse();
    }
  }

}
