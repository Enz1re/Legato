export interface ILoadOnChangeService {
    setPendingTask(task: any);

    cancelPendingTask();
}