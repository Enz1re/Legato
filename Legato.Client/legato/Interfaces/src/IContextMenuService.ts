class ContextMenuItem {
    text: string;
    click: ($itemScope, $event, modelValue, text, $li, data) => void;
}

export interface IContextMenuService {
    guitarOptions: ContextMenuItem[];
    userOptions: ContextMenuItem[];
}