let dateTimer = setInterval(updateDate, 1000);

function updateDate() {
    let temp_element = document.getElementById("datetime");
    let currentDateJS = new Date();
    temp_element.innerHTML = currentDateJS.toLocaleDateString() + " " + currentDateJS.toLocaleTimeString();
}