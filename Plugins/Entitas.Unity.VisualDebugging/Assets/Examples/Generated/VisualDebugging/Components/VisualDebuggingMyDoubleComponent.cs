//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebuggingEntity {

    public MyDoubleComponent myDouble { get { return (MyDoubleComponent)GetComponent(VisualDebuggingComponentsLookup.MyDouble); } }
    public bool hasMyDouble { get { return HasComponent(VisualDebuggingComponentsLookup.MyDouble); } }

    public void AddMyDouble(double newMyDouble) {
        var component = CreateComponent<MyDoubleComponent>(VisualDebuggingComponentsLookup.MyDouble);
        component.myDouble = newMyDouble;
        AddComponent(VisualDebuggingComponentsLookup.MyDouble, component);
    }

    public void ReplaceMyDouble(double newMyDouble) {
        var component = CreateComponent<MyDoubleComponent>(VisualDebuggingComponentsLookup.MyDouble);
        component.myDouble = newMyDouble;
        ReplaceComponent(VisualDebuggingComponentsLookup.MyDouble, component);
    }

    public void RemoveMyDouble() {
        RemoveComponent(VisualDebuggingComponentsLookup.MyDouble);
    }
}
