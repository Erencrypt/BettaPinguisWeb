// Call the dataTables jQuery plugin
$(document).ready(function() {
  $('#dataTable').DataTable( {
      "language": {
          "sDecimal": ",",
          "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
          "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
          "sInfoEmpty": "Kayıt yok",
          "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
          "sInfoPostFix": "",
          "sInfoThousands": ".",
          "sLengthMenu": "Sayfada _MENU_ kayıt göster",
          "sLoadingRecords": "Yükleniyor...",
          "sProcessing": "İşleniyor...",
          "sSearch": "Ara:",
          "sZeroRecords": "Eşleşen kayıt bulunamadı",
          "oPaginate": {
              "sFirst": "İlk",
              "sLast": "Son",
              "sNext": "Sonraki",
              "sPrevious": "Önceki",
              "sScrollY": "200px",
              "sScrollX": "100%",
              "ordering": false,
              responsive: true,
              scrollX: false
          },
          "oAria": {
              "sSortAscending": ": artan sütun sıralamasını aktifleştir",
              "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
          },
          "select": {
              "rows": {
                  "_": "%d kayıt seçildi",
                  "0": "",
                  "1": "1 kayıt seçildi"
              }
          }
      }
  } );
});