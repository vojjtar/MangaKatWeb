<template>
    <div id="mainDiv">
        <div id="downloadDiv">
            <h1>{{info}}</h1>
            <input type="text">
            <a v-on:click="sendData()">
                <img src="@/assets/images/MangaKatLogo.png" alt="">
            </a>
        </div>
    </div>
</template>


<script>

import axios from 'axios'

export default {
    name: "Main",
    data() {
        return {
            info: 0
        }
    },
    // mounted aby se to dalo hned po nasteni asi
    methods: {
        
        sendData: function(){
            axios
            .get('https://localhost:5001/api/MangaAPI/search?mangaName=fgjnfjjkdfgjkdfgjkdfgjfgdffff')
            .then(response => console.log(response))

        }


    }
}
</script>




<style scoped src="@/assets/css/main.css"/>