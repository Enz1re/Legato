import { IPendingTaskService } from "../../Interfaces/interfaces";


export default class PendingTaskService implements IPendingTaskService {
    static $inject = ["$timeout"];
    private taskHandle: ng.IPromise<{}>;
    private task: any;

    constructor(private $timeout: ng.ITimeoutService) {

    }

    setPendingTask(task: any) {
        this.task = task;
        this.taskHandle = this.$timeout(this.task, 750);
    }

    cancelPendingTask() {
        this.$timeout.cancel(this.taskHandle);
    }
}