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

    static IMatcher<VisualDebuggingEntity> _matcherMyBool;

    public static IMatcher<VisualDebuggingEntity> MyBool {
        get {
            if(_matcherMyBool == null) {
                var matcher = (Matcher<VisualDebuggingEntity>)Matcher<VisualDebuggingEntity>.AllOf(VisualDebuggingComponentsLookup.MyBool);
                matcher.componentNames = VisualDebuggingComponentsLookup.componentNames;
                _matcherMyBool = matcher;
            }

            return _matcherMyBool;
        }
    }
}
