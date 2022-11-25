using UnityEngine;
using System;
public abstract class BaseAction : MonoBehaviour
{

    protected Unit unit;
    protected bool isActive;
    protected Action onActionComplete;

    protected virtual void Awake()
    {
        unit = GetComponent<Unit>();
    }

    //abstract is in order to force all the other actions to implement this 
    public abstract string GetActionName();

    //public abstract void TakeAction(GridPosition gridPosition, Action onActionComplete)
}
