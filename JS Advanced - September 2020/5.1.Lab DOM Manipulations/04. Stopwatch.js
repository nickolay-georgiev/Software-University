function stopwatch() {

    let startButton = document.getElementById('startBtn');
    let stopButton = document.getElementById('stopBtn');
    let time = document.getElementById('time');

    startButton.addEventListener('click', function () {

        time.textContent = '00:00';

        startButton.disabled = true;
        stopButton.disabled = false;

        let minutes = 0;
        let seconds = 0;

        let timer = setInterval(function () {
            seconds++;

            if (seconds % 60 === 0) {
                minutes++;
                seconds = ("0" + 0).slice(-2);
            }
            else if (seconds < 10) {
                seconds = ("0" + seconds).slice(-2);
            }

            minutes = ("0" + minutes).slice(-2);

            time.textContent = `${minutes}:${seconds}`

        }, 1000);

        stopButton.addEventListener('click', function (e) {

            clearInterval(timer)

            startButton.disabled = false;
            stopButton.disabled = true;
        })
    })
}