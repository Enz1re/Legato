export interface IModalService {
    openGuitarModal(resolve: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance;
    openLoginModal(resolve: { [key: string]: string | Object | Function | (string | Function)[] }): ng.ui.bootstrap.IModalServiceInstance;
}