import { ILoadOnChangeService } from "../../Interfaces/interfaces";


export default class LoadOnChangeService implements ILoadOnChangeService {
    private taskHandle: ng.IPromise<{}>;
    private task: any;
    static $inject = ["$timeout"];

    constructor(private $timeout: ng.ITimeoutService) {

    }

    setPendingTask(task: any) {
        console.log(task);
        this.task = task;
        this.taskHandle = this.$timeout(this.task, 750);
    }

    cancelPendingTask() {
        this.$timeout.cancel(this.taskHandle);
    }
}