//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class VisualDebuggingMatcher {

    static IMatcher<VisualDebuggingEntity> _matcherPerson;

    public static IMatcher<VisualDebuggingEntity> Person {
        get {
            if(_matcherPerson == null) {
                var matcher = (Matcher<VisualDebuggingEntity>)Matcher<VisualDebuggingEntity>.AllOf(VisualDebuggingComponentsLookup.Person);
                matcher.componentNames = VisualDebuggingComponentsLookup.componentNames;
                _matcherPerson = matcher;
            }

            return _matcherPerson;
        }
    }
}
