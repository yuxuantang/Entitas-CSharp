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

    static IMatcher<VisualDebuggingEntity> _matcherTexture2D;

    public static IMatcher<VisualDebuggingEntity> Texture2D {
        get {
            if(_matcherTexture2D == null) {
                var matcher = (Matcher<VisualDebuggingEntity>)Matcher<VisualDebuggingEntity>.AllOf(VisualDebuggingComponentsLookup.Texture2D);
                matcher.componentNames = VisualDebuggingComponentsLookup.componentNames;
                _matcherTexture2D = matcher;
            }

            return _matcherTexture2D;
        }
    }
}
