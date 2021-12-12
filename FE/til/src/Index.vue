<template>
    <div id="app">
        <TilHeader/>
        <Pagepick/>
    </div>
</template>

<script>
import TilHeader from './components/TilHeader.vue'
import Pagepick from './components/PagePick.vue'


export default {
    name: 'TilIndex',
    components:{
        TilHeader,
        Pagepick,
    },
    data() {
        return {
            title:'제목'
        };
    },

    mounted() {
        
    },

    methods: {
        
    },
};
</script>

<style>
    div[data-temp1]{
        color: bisque;
    }
    @import url(assets/css/common.css);
</style>