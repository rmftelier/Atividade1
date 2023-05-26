import axios from "axios";

const api = axios.create({
    baseURL: "http://localhost:5261/",
});

export default api;