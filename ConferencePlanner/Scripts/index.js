angular
    .module('app')
    .service('IndexPageService', ['$http', '$q', function ($http, $q) {

        this.flagAttendance = function (url, conferenceId) {
            return $http({
                method: 'POST',
                url: url,
                data: { conferenceId: conferenceId }
            });
        };

    }]);
