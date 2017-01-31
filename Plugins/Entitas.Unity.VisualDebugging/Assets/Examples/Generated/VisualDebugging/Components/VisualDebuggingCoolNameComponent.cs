//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class VisualDebuggingEntity {

    public CoolNameComponent coolName { get { return (CoolNameComponent)GetComponent(VisualDebuggingComponentsLookup.CoolName); } }
    public bool hasCoolName { get { return HasComponent(VisualDebuggingComponentsLookup.CoolName); } }

    public void AddCoolName(BadName newValue) {
        var component = CreateComponent<CoolNameComponent>(VisualDebuggingComponentsLookup.CoolName);
        component.value = newValue;
        AddComponent(VisualDebuggingComponentsLookup.CoolName, component);
    }

    public void ReplaceCoolName(BadName newValue) {
        var component = CreateComponent<CoolNameComponent>(VisualDebuggingComponentsLookup.CoolName);
        component.value = newValue;
        ReplaceComponent(VisualDebuggingComponentsLookup.CoolName, component);
    }

    public void RemoveCoolName() {
        RemoveComponent(VisualDebuggingComponentsLookup.CoolName);
    }
}
