//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebuggingEntity {

    public MyBoolComponent myBool { get { return (MyBoolComponent)GetComponent(VisualDebuggingComponentsLookup.MyBool); } }
    public bool hasMyBool { get { return HasComponent(VisualDebuggingComponentsLookup.MyBool); } }

    public void AddMyBool(bool newMyBool) {
        var component = CreateComponent<MyBoolComponent>(VisualDebuggingComponentsLookup.MyBool);
        component.myBool = newMyBool;
        AddComponent(VisualDebuggingComponentsLookup.MyBool, component);
    }

    public void ReplaceMyBool(bool newMyBool) {
        var component = CreateComponent<MyBoolComponent>(VisualDebuggingComponentsLookup.MyBool);
        component.myBool = newMyBool;
        ReplaceComponent(VisualDebuggingComponentsLookup.MyBool, component);
    }

    public void RemoveMyBool() {
        RemoveComponent(VisualDebuggingComponentsLookup.MyBool);
    }
}
