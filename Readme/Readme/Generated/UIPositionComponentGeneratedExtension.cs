//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;
using Entitas.Api;

public partial class GameEntity : Entity {

    public UIPositionComponent uIPosition { get { return (UIPositionComponent)GetComponent(UIComponentIds.UIPosition); } }
    public bool hasUIPosition { get { return HasComponent(UIComponentIds.UIPosition); } }

    public void AddUIPosition(int newX, int newY) {
        var component = CreateComponent<UIPositionComponent>(UIComponentIds.UIPosition);
        component.x = newX;
        component.y = newY;
        AddComponent(UIComponentIds.UIPosition, component);
    }

    public void ReplaceUIPosition(int newX, int newY) {
        var component = CreateComponent<UIPositionComponent>(UIComponentIds.UIPosition);
        component.x = newX;
        component.y = newY;
        ReplaceComponent(UIComponentIds.UIPosition, component);
    }

    public void RemoveUIPosition() {
        RemoveComponent(UIComponentIds.UIPosition);
    }
}

public partial class UIMatcher {

    static IMatcher<GameEntity> _matcherUIPosition;

    public static IMatcher<GameEntity> UIPosition {
        get {
            if(_matcherUIPosition == null) {
                var matcher = (Matcher<GameEntity>)Matcher<GameEntity>.AllOf(UIComponentIds.UIPosition);
                matcher.componentNames = UIComponentIds.componentNames;
                _matcherUIPosition = matcher;
            }

            return _matcherUIPosition;
        }
    }
}
