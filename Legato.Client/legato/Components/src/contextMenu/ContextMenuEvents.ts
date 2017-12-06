export class ContextMenuEvents {
    // Triggers when all the context menus have been closed
    static ContextMenuAllClosed: 'context-menu-all-closed';
    // Triggers when any single conext menu is called.
    // Closing all context menus triggers this for each level open
    static ContextMenuClosed: 'context-menu-closed';
    // Triggers right before the very first context menu is opened
    static ContextMenuOpening: 'context-menu-opening';
    // Triggers right after any context menu is opened
    static ContextMenuOpened: 'context-menu-opened';
}