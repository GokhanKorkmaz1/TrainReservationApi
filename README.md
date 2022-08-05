# TrainReservationApi
<br />
Request example : <br />
<br />
{ <br />
  &nbsp;&nbsp; "train": { <br />
  &nbsp;&nbsp;  "name": "Başkent Ekspres", <br />
  &nbsp;&nbsp;  "waggons": [ <br />
  &nbsp;&nbsp;    { <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      "name": "Vagon 1", <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;     "capacity": 100, <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      "numberofReservedSeats": 68 <br />
  &nbsp;&nbsp;   }, <br />
  &nbsp;&nbsp;   { <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      "name": "Vagon 2", <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      "capacity": 90, <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      "numberofReservedSeats": 50 <br />
  &nbsp;&nbsp;    }, <br />
  &nbsp;&nbsp;    { <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      "name": "Vagon 3", <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      "capacity": 80, <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;      "numberofReservedSeats": 80 <br />
  &nbsp;&nbsp;    } <br />
  &nbsp;&nbsp;  ] <br />
  &nbsp;&nbsp; }, <br />
  &nbsp;&nbsp; "numberofPassenger": 3, <br />
  &nbsp;&nbsp; "isAllowDifferentWaggons": true <br />
  &nbsp;&nbsp; } <br />
  &nbsp;&nbsp;<br />
  Response : <br />
  &nbsp;&nbsp; <br />
  &nbsp;&nbsp; { <br />
  &nbsp;&nbsp; "isReservable": true, <br />
  &nbsp;&nbsp; "placementDetails": [ <br />
  &nbsp;&nbsp;  { <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    "waggonName": "Vagon 1", <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    "numberofPeople": 1 <br />
  &nbsp;&nbsp;  }, <br />
  &nbsp;&nbsp;  { <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    "waggonName": "Vagon 2", <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    "numberofPeople": 2 <br />
  &nbsp;&nbsp;  } <br />
  &nbsp;&nbsp; ] <br />
  &nbsp;&nbsp;} <br />
