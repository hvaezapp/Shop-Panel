﻿(function ($) {
    function Allsupports() {
        var $this = this;

        function initilizeModel() {
            $("#modal-action-all").on('loaded.bs.modal', function (e) {

            }).on('hidden.bs.modal', function (e) {
                $(this).removeData('bs.modal');
            });
        }
        $this.init = function () {
            initilizeModel();
        }
    }
    $(function () {
        var self = new Allsupports();
        self.init();
    })
}(jQuery))