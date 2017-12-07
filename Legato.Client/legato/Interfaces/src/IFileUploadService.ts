export interface IFileUploadService {
    file: ng.angularFileUpload.IFileUploadConfigFile;

    upload(file: any);
}