//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class TestMatcher {

    static IMatcher<TestEntity> _matcherNameAge;

    public static IMatcher<TestEntity> NameAge {
        get {
            if(_matcherNameAge == null) {
                var matcher = (Matcher<TestEntity>)Matcher<TestEntity>.AllOf(TestComponentsLookup.NameAge);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherNameAge = matcher;
            }

            return _matcherNameAge;
        }
    }
}
