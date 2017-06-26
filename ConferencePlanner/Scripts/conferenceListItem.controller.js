angular
    .module('app')
    .controller('ConferenceListItemController', ['$attrs', 'IndexPageService',
        function ($attrs, indexPage) {
        var vm = this;
        var conference = JSON.parse($attrs.conference);

        this.id = conference.Id;
        this.name = conference.Name;
        this.startDate = conference.StartDateString;
        this.location = conference.Location;
        this.description = conference.Description;
        this.attendeeCount = conference.AttendeeCount;

        this.flagAttendance = function () {
            indexPage.flagAttendance($attrs.url, vm.id)
                .then(function (response) {
                    vm.attendeeCount = response.data.newAttendeeCount;
                });
        };
    }]);