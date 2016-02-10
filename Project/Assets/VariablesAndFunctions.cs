using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    int totalHealth = 7; 
    
    void Start(){
        totalHealth = DoubleHealing(totalHealth);
        Debug.Log (totalHealth);
    }
    
    int DoubleHealing(int number){
        int ret;
        
        ret = number * 2;
        
        return ret;
    }
}
