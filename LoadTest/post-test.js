import http from 'k6/http';

export default function () {
    const payload = JSON.stringify({
        name: 'lorem',
        surname: 'ipsum',
    });
    const headers = { 'Content-Type': 'application/json' };
    http.post('https://httpbin.test.k6.io/post', payload, { headers });
}
