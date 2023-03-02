using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionHandler : MonoBehaviour
{
    [SerializeField] float _radius = 1;

    [SerializeField] LayerMask _interactableLayer;

    UserActions _controls;

    private void Awake()
    {
        //Invoca a la clase InteractionRequested//
        
        
        EventManager._InputSet.AddListener(InputSet);

    }

    void InputSet(UserActions input)
    {
        _controls = input;

        _controls.Player.Interactue.performed += InteractionRequested;

    }



    void InteractionRequested(InputAction.CallbackContext context)
    {
        
        //Almacena todos los objectos que estan en _interactableLayer al chocar con una esfera generada77
        //mediante Physics en una lista//
        Collider[] _found = Physics.OverlapSphere(transform.position, _radius, _interactableLayer);


        //El siguiente if comprobara que la lista contenga algo//
        if(_found.Length > 0)
        {
            //El siguiente if lo que hara sera intentar acceder a IInteractable, si encuentra que el//
            //objecto no lo tiene implementado, si lo tiene activara la función.//
            int _closestEntityIndex = GetClosestIndex(_found);

            if (_found[_closestEntityIndex].TryGetComponent(out IInteractable interactable))
            {
                print("Interacting with " + _found[_closestEntityIndex].name);
                interactable.Interact();
            }
            else
                Debug.LogWarning("Object no doesn´t have implement IInteractable");
        }

       
    }

    int GetClosestIndex(Collider[] _found)
    {
        //Esto va a calcular que objecto es el más cercano al objeto con este script.//
        //Se calcula mediante el Vector3.Distance la distancia(_closestDistance) entre el objeto con este script y el primer elemento//
        //en la lista.//
        int _closestIndex = 0;
        float _closestDistance = Vector3.Distance(_found[0].transform.position, transform.position);
        float _newDistance;

        //Mediante un bucle vamos a comprobar todos los elementos de la lista, para ver cual es el más cercano,//
        //si la nueva distancia(_newDistance) es menor que la anterior se actualiza _closestDistance, esto hara que cuando//
        //se invoque el index del más cercano se le pasara a la lista, provocando que se active el correspondiente.//

        for (int i = 1; i < _found.Length; i++)
        {
            _newDistance = Vector3.Distance(_found[i].transform.position, transform.position);

            if(_newDistance < _closestDistance)
            {
                _closestIndex = i;
                _closestDistance = _newDistance;
            }
        }
        return _closestIndex;
    }


    private void OnDestroy()
    {
        _controls.Player.Interactue.performed -= InteractionRequested;
    }
}
