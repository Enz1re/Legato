class ContextMenuItem {
    text: string;
    click: ($itemScope, $event, modelValue, text, $li, data) => void;
}

export interface IContextMenuService {
    menuOptions: ContextMenuItem[];
}