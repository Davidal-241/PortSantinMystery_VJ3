using UnityEngine;

[System.Serializable]

public class DialogueLine
{

    public Speaker speaker;
    public Sprite _SpritePortrains1, _SpritePortrains2;
    public Sprite UItextBox;
    [TextArea]
    public string dialogue;

}
