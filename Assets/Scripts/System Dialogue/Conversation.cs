using UnityEngine;

[CreateAssetMenu( fileName ="New Conversation", menuName = "Dialogue/ New Conversation")]
public class Conversation : ScriptableObject
{

    [SerializeField]private DialogueLine[] allLines;

    

    public DialogueLine GetLineByIndex(int index)
    {
        //Debug.Log(allLines.Length + " lines for " + name + "'s conversation. Trying to get lien nº " + index);

        return allLines[index];
    }

    public int GetLength()
    {
        return allLines.Length;
    }

    
}
